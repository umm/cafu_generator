using System.IO;
using CAFU.Generator.Enumerates;
using UnityEngine;
using UnityModule.ContextManagement;

namespace CAFU.Generator
{

    public interface IClassStructure
    {
        string Name { get; }

        void OnGUI();

        void Generate(bool overwrite);
    }

    public interface IClassStructureExtension
    {
        void OnGUI();

        void Process(Parameter parameter);
    }

    public abstract class ClassStructureBase : StructureBase, IClassStructure
    {
        protected const string OutputDirectory = "Scripts";

        protected const string ScriptExtension = ".cs";

        public abstract string Name { get; }

        protected abstract ParentLayerType ParentLayerType { get; }

        protected abstract LayerType LayerType { get; }

        public virtual void OnGUI()
        {
        }

        public abstract void Generate(bool overwrite);

        protected virtual string CreateNamespace(Parameter parameter) => $"{CreateNamespacePrefix()}{ParentLayerType.ToString()}.{LayerType.ToString()}";

        protected virtual string CreateOutputPath(Parameter parameter) => Path.Combine(Application.dataPath, OutputDirectory, parameter.ParentLayerType.ToString(), parameter.LayerType.ToString(), $"{parameter.ClassName}{ScriptExtension}");

        protected static string CreateNamespacePrefix()
        {
            if (GeneratorWindow.ProjectContext == default(IProjectContext))
            {
                return string.Empty;
            }

            return $"{GeneratorWindow.ProjectContext.NamespacePrefix.Trim('.')}.";
        }
    }
}