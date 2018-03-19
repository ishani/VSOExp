using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSOExp
{
    public class LayoutTreeNode : Aga.Controls.Tree.Node
    {
        private string _size;
        public virtual string Size
        {
            get { return _size; }
            set {
                if ( _size != value )
                {
                    _size = value;
                    NotifyModel();
                }
            }
        }

        private string _padding;
        public virtual string Padding
        {
            get { return _padding; }
            set {
                if ( _padding != value )
                {
                    _padding = value;
                    NotifyModel();
                }
            }
        }

        private string _gaps;
        public virtual string Gaps
        {
            get { return _gaps; }
            set {
                if ( _gaps != value )
                {
                    _gaps = value;
                    NotifyModel();
                }
            }
        }

        private string _type;
        public virtual string TypeName
        {
            get { return _type; }
            set {
                if ( _type != value )
                {
                    _type = value;
                    NotifyModel();
                }
            }
        }
    }
}
