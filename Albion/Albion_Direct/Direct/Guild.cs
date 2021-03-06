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
using System.Linq;

namespace Albion_Direct
{
    /* Internal type: atg */
    public partial class Guild
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private atg _internal;
        
        #region Properties
        
        public atg Guild_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public GuildMember[] GetMembers() => _internal.ag().Select(x =>(GuildMember)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public Guild(atg instance)
        {
            _internal = instance;
        }
        
        static Guild()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator atg(Guild instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Guild(atg instance)
        {
            return new Guild(instance);
        }
        
        public static implicit operator bool(Guild instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
