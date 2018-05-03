using System.IO;
using CAFU.Generator.Enumerates;
using UnityEngine;

namespace CAFU.Generator
{
    public interface IStructure
    {

    }

    public abstract class StructureBase : IStructure
    {
        protected virtual string ModuleDirectory { get; } = "Modules";

        protected virtual string ModuleName { get; } = "umm@cafu_generator";

        protected virtual string TemplateDirectory { get; } = "Templates";

        protected virtual string TemplateExtension { get; } = ".txt";

        protected virtual string CreateTemplatePath(TemplateType templateType, string templateName)
        {
            // プロジェクト側のファイルを走査
            var path = Path.Combine(
                Application.dataPath,
                TemplateDirectory,
                templateType.ToString(),
                // Windows 用に念のためディレクトリセパレータを置換
                templateName.Replace("/", Path.DirectorySeparatorChar.ToString()) + TemplateExtension
            );
            if (File.Exists(path))
            {
                return path;
            }

            // umm 側のファイルを走査
            path = Path.Combine(
                Application.dataPath,
                ModuleDirectory,
                ModuleName,
//                "CAFU/Generator",
                TemplateDirectory,
                templateType.ToString(),
                // Windows 用に念のためディレクトリセパレータを置換
                templateName.Replace("/", Path.DirectorySeparatorChar.ToString()) + TemplateExtension
            );
            if (File.Exists(path))
            {
                return path;
            }

            throw new FileNotFoundException("Template file not found.", path);
        }
    }
}