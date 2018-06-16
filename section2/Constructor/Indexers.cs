/*
- Indexer is a special kind of property that allows accessing elements of a list by an index.

- If a class has the semantics of a list, or collection, we can define an indexer property for it.

  This way it’s easier to get or set items in the collection.*/

public class HttpCookie
{
    public string this[string key]
    {
        get {}
        set {}
    }
}