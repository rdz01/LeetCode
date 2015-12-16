using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _071_SimplifyPath
    {
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrEmpty(path)) { return "/"; }

            var folders = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var pathList = new List<string>();
            foreach (var folder in folders)
            {
                if (folder.Equals(".")) { continue; }
                else if (folder.Equals(".."))
                    if (pathList.Count > 0) { pathList.RemoveAt(pathList.Count - 1); } else { continue; }
                else { pathList.Add(folder); }
            }

            var result = "/";
            if (pathList.Count > 0) { result += string.Join("/", pathList); }

            return result;
        }
    }
}
