using System.Threading.Tasks;
using System.Windows.Media;
using MVVMApps.Metro;
using Mahapps.Metro.Tests.TestHelpers;
using Xunit;

namespace Mahapps.Metro.Tests
{
    public class CleanWindowTest : AutomationTestBase
    {
        [Fact]
        public async Task DefaultWindowCommandColorIsBlack()
        {
            await TestHost.SwitchToAppThread();

            var window = await WindowHelpers.CreateInvisibleWindowAsync<CleanWindow>();

            var blackBrushColor = ((SolidColorBrush)ThemeManager.GetAppTheme("BaseLight").Resources["BlackBrush"]).Color;

            window.AssertWindowCommandsColor(blackBrushColor);
        }
    }
}
