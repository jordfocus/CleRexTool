using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text.RegularExpressions;

namespace ResourceCleaner
{
    public class ResourceFileHandler
    {
        public delegate void StatusUpdateHandler(object sender, ProgressEventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;
        /// <summary>
        /// Hashtable that represents resource file
        /// </summary>
        private Hashtable ResourceItems;

        /// <summary>
        /// Empty constructor. Inits resource hashtable.
        /// </summary>
        public ResourceFileHandler()
        {
            // init resource items hash table
            ResourceItems = new Hashtable();
        }
        /// <summary>
        /// Empty constructor. Inits and loads resource hashtable.
        /// </summary>
        /// <param name="resourceFilePath">Resource file path that we want to load</param>
        public ResourceFileHandler(string resourceFilePath)
        {
            // init resource items hash table
            ResourceItems = new Hashtable();
            // load items
            LoadResource(resourceFilePath);
        }
        /// <summary>
        /// Loads resource file items into class hashtable
        /// </summary>
        /// <param name="resourceFilePath">Path to the resource file that we want to load</param>
        public void LoadResource(string resourceFilePath)
        {
            // delete all previous resource items
            ResourceItems.Clear();
            // load the new resource into the hashtable 
            var resourceReader = new ResXResourceReader(resourceFilePath);
            foreach (DictionaryEntry entry in resourceReader)
            {
                ResourceItems.Add(entry.Key.ToString(), entry.Value == null ? string.Empty : entry.Value.ToString());
            }
            resourceReader.Close(); 
        }
        /// <summary>
        /// Remove key from resources hashtable
        /// </summary>
        /// <param name="key">key that we want to remove</param>
        public void RemoveKey(string key)
        {
            ResourceItems.Remove(key);
        }
        /// <summary>
        /// Removes keys from resource hashtable
        /// </summary>
        /// <param name="keys">list of keys that we want to remove</param>
        public void RemoveKeys(string[] keys)
        {
            foreach (var key in keys)
            {
                ResourceItems.Remove(key);   
            }
        }
        /// <summary>
        /// Finds all the RESX file items that are not used in the project
        /// </summary>
        /// <param name="projectFolder">Project in which we are searching the usage of the RESX items</param>
        /// <param name="filter">Filter for the file types that we want to be included in the search</param>
        /// <returns></returns>
        public string[] GetUnusedItems(string projectFolder, string filter = "*.cs")
        {
            var unusedItems = new List<string>();
            var files = Directory.GetFiles(projectFolder, filter, SearchOption.AllDirectories);
            foreach (var key in ResourceItems.Keys)
            {
                var args = new ProgressEventArgs(string.Format("\n-> Searching for key {0}", key));
                OnUpdateStatus(this, args);
                var keyRegex = string.Format("(?<![a-zA-Z0-9]){0}(?![a-zA-Z0-9])", key);
                var isUsed = false;
                foreach (var file in files)
                {
                    // skip designer files
                    if (file.Contains("Designer.cs"))
                        continue;
                    // If RESX Entry found in a given file
                    // if (File.ReadAllText(file).Contains(key.ToString()))
                    if (Regex.Match(File.ReadAllText(file), keyRegex).Success)
                    {
                        args = new ProgressEventArgs(string.Format("\n-> Resource key {0} is used!", key));
                        OnUpdateStatus(this, args);
                        isUsed = true;
                        break;
                    }
                }
                // If the entry is not found add it to return list
                if (!isUsed)
                {
                    args = new ProgressEventArgs(string.Format("\n-> Resource key {0} is NOT used!", key));
                    OnUpdateStatus(this, args);
                    unusedItems.Add(key.ToString());   
                }
            }
            return unusedItems.ToArray();
        }
        /// <summary>
        /// Creates new resource file from the current dictionary entries
        /// </summary>
        /// <param name="newResourceFilePath">The parh to the new resource file</param>
        public void CreateResourceFile(string newResourceFilePath)
        {
            var resourceWriter = new ResXResourceWriter(newResourceFilePath);
            foreach (string key in ResourceItems.Keys)
            {
                resourceWriter.AddResource(key, ResourceItems[key]);
            }
            resourceWriter.Generate();
            resourceWriter.Close();
        }
    }

    public class ProgressEventArgs : EventArgs
{
    public string Status { get; private set; }

    public ProgressEventArgs(string status)
    {
        Status = status;
    }
}
}
