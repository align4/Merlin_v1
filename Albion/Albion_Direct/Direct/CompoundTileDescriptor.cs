////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: nw */
    public partial class CompoundTileDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private nw _internal;
        
        #region Properties
        
        public nw CompoundTileDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public CompoundTileDescriptor(nw instance)
        {
            _internal = instance;
        }
        
        static CompoundTileDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator nw(CompoundTileDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator CompoundTileDescriptor(nw instance)
        {
            return new CompoundTileDescriptor(instance);
        }
        
        public static implicit operator bool(CompoundTileDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
