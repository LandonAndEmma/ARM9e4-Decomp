using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace NewARM9.Properties
{
    // Token: 0x0200000B RID: 11
    [DebuggerNonUserCode]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [CompilerGenerated]
    internal class Resources
    {
        // Token: 0x06000020 RID: 32 RVA: 0x000041DC File Offset: 0x000023DC
        internal Resources()
        {
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000021 RID: 33 RVA: 0x000041E8 File Offset: 0x000023E8
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (Resources.resourceMan == null)
                {
                    ResourceManager resourceManager = new ResourceManager("NewARM9.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = resourceManager;
                }
                return Resources.resourceMan;
            }
        }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000022 RID: 34 RVA: 0x00004230 File Offset: 0x00002430
        // (set) Token: 0x06000023 RID: 35 RVA: 0x00004247 File Offset: 0x00002447
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }

        // Token: 0x04000035 RID: 53
        private static ResourceManager resourceMan;

        // Token: 0x04000036 RID: 54
        private static CultureInfo resourceCulture;
    }
}
