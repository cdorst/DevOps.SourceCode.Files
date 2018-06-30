using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace DevOps.SourceCode.Files
{
    /// <summary>Objects of abstract <seealso cref="SourceCodeFile"/> type describe files that can be written into the file system at a specified <seealso cref="Path"/> under the current working directory</summary>
    public abstract class SourceCodeFile
    {
        public SourceCodeFile() { }
        public SourceCodeFile(in string path) => Path = path;

        /// <summary>The file path under the repository root (including file name and extension)</summary>
        public string Path { get; set; }

        /// <summary>Returns source code file's text content</summary>
        public abstract string GetContents();

        /// <summary>Writes the file into the file system at the specified path under the current working directory</summary>
        public void WriteFile() => WriteAllText(GetPath(), GetContents());

        /// <summary>Returns the full file path by combining the current working directory with the specified Path</summary>
        private string GetPath() => Combine(GetCurrentDirectory(), Path);
    }
}
