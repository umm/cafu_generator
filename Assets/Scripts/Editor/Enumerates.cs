namespace CAFU.Generator.Enumerates
{
    public enum TemplateType
    {
        Class,
        Partial,
    }

    public enum ParentLayerType
    {
        Application,
        Presentation,
        Domain,
        Data,
        Other,
    }

    public enum LayerType
    {
        Enumerates,
        Constants,
        View,
        Presenter,
        Controller,
        UseCase,
        Model,
        Translator,
        Repository,
        DataStore,
        Entity,
        Other,
    }

    public enum Accessibility
    {
        Private,
        Protected,
        Internal,
        Public,
    }
}