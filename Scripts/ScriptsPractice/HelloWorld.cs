using DynamicPatcher;
using Extension.Ext;
using Extension.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DionysusPractice.DynamicPatcher.Scripts.ScriptsPractice
{
    [Serializable]
    public class HelloWorld : TechnoScriptable
    {
        public HelloWorld(TechnoExt owner) : base(owner) { }

        int count = 0;

        public override void OnUpdate()
        {
            Logger.Log($"HelloWorld {count++}");
            base.OnUpdate();
        }
    }
}
