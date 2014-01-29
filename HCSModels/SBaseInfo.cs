using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*********************************
 * 类名： Patient
 * 创建日期：2012-12-09
 * 功能描述：基本信息实体类
 * *******************************/
namespace HCS.Models
{
    [Serializable]
    public class SBaseInfo
    {
        protected int id;
        protected string name;
        protected int infoType;

        public int Id
        {
            get { return  id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int InfoType
        {
            get { return infoType; }
            set { infoType = value; }
        }
    }
}
