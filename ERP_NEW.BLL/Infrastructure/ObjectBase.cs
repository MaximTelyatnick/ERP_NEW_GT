using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Reflection;

namespace ERP_NEW.BLL.Infrastructure
{
    public abstract class ObjectBase : System.ComponentModel.IEditableObject
    {
        Hashtable props = null;

        #region IEditableObject Members
        /// <summary>
        /// Set object in edit mode and save current values
        /// </summary>
        public void BeginEdit()
        {
            //exit if in Edit mode
            if (null != props) return;

            //enumerate properties
            PropertyInfo[] properties = (this.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            props = new Hashtable(properties.Length - 1);

            for (int i = 0; i < properties.Length; i++)
            {
                //check if there is set accessor
                if (null != properties[i].GetSetMethod())
                {
                    object value = properties[i].GetValue(this, null);
                    props.Add(properties[i].Name, value);
                }
            }
        }

        /// <summary>
        /// Reject changes made to object since method BeginEdit() was called
        /// </summary>
        public void CancelEdit()
        {
            //check for unapporpriate call sequence
            if (null == props) return;

            //restore old values
            PropertyInfo[] properties = (this.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < properties.Length; i++)
            {
                //check if there is set accessor
                if (null != properties[i].GetSetMethod())
                {
                    object value = props[properties[i].Name];
                    properties[i].SetValue(this, value, null);
                }
            }

            //delete current values            
            props = null;
        }

        /// <summary>
        /// Commit changes in object since method BeginEdit() was called
        /// </summary>
        public void EndEdit()
        {
            //delete current values            
            props = null;
        }

        #endregion
    }
}
