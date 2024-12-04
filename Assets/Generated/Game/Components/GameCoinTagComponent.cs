//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.Tag.CoinTag coinTagComponent = new Components.Tag.CoinTag();

    public bool isCoinTag {
        get { return HasComponent(GameComponentsLookup.CoinTag); }
        set {
            if (value != isCoinTag) {
                var index = GameComponentsLookup.CoinTag;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : coinTagComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherCoinTag;

    public static Entitas.IMatcher<GameEntity> CoinTag {
        get {
            if (_matcherCoinTag == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CoinTag);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCoinTag = matcher;
            }

            return _matcherCoinTag;
        }
    }
}