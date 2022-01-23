using Microsoft.JSInterop;
using IndexedDB.Blazor;

namespace ThingsStorage.Data
{
    public class ThingsDb : IndexedDb
    {
        public ThingsDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        public IndexedSet<Thing> Things { get; set; }
    }
}