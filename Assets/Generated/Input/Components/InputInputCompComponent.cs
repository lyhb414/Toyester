//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity inputCompEntity { get { return GetGroup(InputMatcher.InputComp).GetSingleEntity(); } }
    public Components.Input.InputComp inputComp { get { return inputCompEntity.inputComp; } }
    public bool hasInputComp { get { return inputCompEntity != null; } }

    public InputEntity SetInputComp(UnityEngine.Vector2 newDir, UnityEngine.Vector2 newMousePos, bool newMainButton, bool newMainButtonDown, bool newSecondaryButton, bool newSecondaryButtonDown) {
        if (hasInputComp) {
            throw new Entitas.EntitasException("Could not set InputComp!\n" + this + " already has an entity with Components.Input.InputComp!",
                "You should check if the context already has a inputCompEntity before setting it or use context.ReplaceInputComp().");
        }
        var entity = CreateEntity();
        entity.AddInputComp(newDir, newMousePos, newMainButton, newMainButtonDown, newSecondaryButton, newSecondaryButtonDown);
        return entity;
    }

    public void ReplaceInputComp(UnityEngine.Vector2 newDir, UnityEngine.Vector2 newMousePos, bool newMainButton, bool newMainButtonDown, bool newSecondaryButton, bool newSecondaryButtonDown) {
        var entity = inputCompEntity;
        if (entity == null) {
            entity = SetInputComp(newDir, newMousePos, newMainButton, newMainButtonDown, newSecondaryButton, newSecondaryButtonDown);
        } else {
            entity.ReplaceInputComp(newDir, newMousePos, newMainButton, newMainButtonDown, newSecondaryButton, newSecondaryButtonDown);
        }
    }

    public void RemoveInputComp() {
        inputCompEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public Components.Input.InputComp inputComp { get { return (Components.Input.InputComp)GetComponent(InputComponentsLookup.InputComp); } }
    public bool hasInputComp { get { return HasComponent(InputComponentsLookup.InputComp); } }

    public void AddInputComp(UnityEngine.Vector2 newDir, UnityEngine.Vector2 newMousePos, bool newMainButton, bool newMainButtonDown, bool newSecondaryButton, bool newSecondaryButtonDown) {
        var index = InputComponentsLookup.InputComp;
        var component = (Components.Input.InputComp)CreateComponent(index, typeof(Components.Input.InputComp));
        component.Dir = newDir;
        component.MousePos = newMousePos;
        component.MainButton = newMainButton;
        component.MainButtonDown = newMainButtonDown;
        component.SecondaryButton = newSecondaryButton;
        component.SecondaryButtonDown = newSecondaryButtonDown;
        AddComponent(index, component);
    }

    public void ReplaceInputComp(UnityEngine.Vector2 newDir, UnityEngine.Vector2 newMousePos, bool newMainButton, bool newMainButtonDown, bool newSecondaryButton, bool newSecondaryButtonDown) {
        var index = InputComponentsLookup.InputComp;
        var component = (Components.Input.InputComp)CreateComponent(index, typeof(Components.Input.InputComp));
        component.Dir = newDir;
        component.MousePos = newMousePos;
        component.MainButton = newMainButton;
        component.MainButtonDown = newMainButtonDown;
        component.SecondaryButton = newSecondaryButton;
        component.SecondaryButtonDown = newSecondaryButtonDown;
        ReplaceComponent(index, component);
    }

    public void RemoveInputComp() {
        RemoveComponent(InputComponentsLookup.InputComp);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherInputComp;

    public static Entitas.IMatcher<InputEntity> InputComp {
        get {
            if (_matcherInputComp == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.InputComp);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherInputComp = matcher;
            }

            return _matcherInputComp;
        }
    }
}