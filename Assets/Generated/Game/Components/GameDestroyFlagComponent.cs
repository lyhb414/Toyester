//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.Base.DestroyFlag destroyFlagComponent = new Components.Base.DestroyFlag();

    public bool isDestroyFlag {
        get { return HasComponent(GameComponentsLookup.DestroyFlag); }
        set {
            if (value != isDestroyFlag) {
                var index = GameComponentsLookup.DestroyFlag;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : destroyFlagComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherDestroyFlag;

    public static Entitas.IMatcher<GameEntity> DestroyFlag {
        get {
            if (_matcherDestroyFlag == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DestroyFlag);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDestroyFlag = matcher;
            }

            return _matcherDestroyFlag;
        }
    }
}