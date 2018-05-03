namespace CAFU.Generator.Enumerates
{
    public enum TemplateType
    {
        Class,
        Partial,
    }

    public enum ParentLayerType
    {
        Presentation,
        Domain,
        Data,
    }

    public enum LayerType
    {
        View,
        Presenter,
        Controller,
        UseCase,
        Model,
        Translator,
        Repository,
        DataStore,
        Entity,
    }

    public enum Accessibility
    {
        Private,
        Protected,
        Internal,
        Public,
    }
}