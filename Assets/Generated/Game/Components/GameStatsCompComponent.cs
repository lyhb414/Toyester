//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Stat.StatsComp statsComp { get { return (Components.Stat.StatsComp)GetComponent(GameComponentsLookup.StatsComp); } }
    public bool hasStatsComp { get { return HasComponent(GameComponentsLookup.StatsComp); } }

    public void AddStatsComp(float[] newVars, Utils.Event.EventDispatcher newEventDispatcher) {
        var index = GameComponentsLookup.StatsComp;
        var component = (Components.Stat.StatsComp)CreateComponent(index, typeof(Components.Stat.StatsComp));
        component.Vars = newVars;
        component.EventDispatcher = newEventDispatcher;
        AddComponent(index, component);
    }

    public void ReplaceStatsComp(float[] newVars, Utils.Event.EventDispatcher newEventDispatcher) {
        var index = GameComponentsLookup.StatsComp;
        var component = (Components.Stat.StatsComp)CreateComponent(index, typeof(Components.Stat.StatsComp));
        component.Vars = newVars;
        component.EventDispatcher = newEventDispatcher;
        ReplaceComponent(index, component);
    }

    public void RemoveStatsComp() {
        RemoveComponent(GameComponentsLookup.StatsComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherStatsComp;

    public static Entitas.IMatcher<GameEntity> StatsComp {
        get {
            if (_matcherStatsComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StatsComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStatsComp = matcher;
            }

            return _matcherStatsComp;
        }
    }
}
