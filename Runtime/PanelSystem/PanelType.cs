﻿using System.Threading.Tasks;
using UnityEngine;

namespace Gameframe.GUI.PanelSystem
{
    [CreateAssetMenu(menuName = "Gameframe/PanelSystem/PanelType")]
    public class PanelType : ScriptableObject
    {
        public enum Visibility
        {
            Opaque,
            Transparent
        }
        
        //What info should be in the type of a panel?
        //prefab/addressable asset
        //opaque/transparent - shows or hides panels below it in a stack?

        [SerializeField] private PanelViewBase prefab;
        public PanelViewBase Prefab => prefab;
        
        [SerializeField]
        private Visibility visibility = Visibility.Opaque;

        public Visibility VisibilityType
        {
            get => visibility;
            set => visibility = value;
        }

        public virtual Task<PanelViewBase> GetPrefabAsync()
        {
            return Task.FromResult(prefab);
        }
    }
}
