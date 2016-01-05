using GSeriesColorizer.Lib;
using EnvDTE;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Resources.Shell;

namespace GSeriesColorizerReSharperPlugin
{
    [SolutionComponent]
    public class DevEnv
    {
        public DevEnv()
        {
            _dte = Shell.Instance.GetComponent<DTE>();
        }

        private readonly DTE _dte;

        private void SubscribeEvents()
        {
            var events = _dte.Events;
            if (events == null)
                return;

            var buildEvents = events.BuildEvents;
            if (buildEvents == null)
                return;

           
                buildEvents.OnBuildBegin += OnBuildBegin;
           
               // buildEvents.OnBuildBegin -= OnBuildBegin;
           

           
                buildEvents.OnBuildDone += OnBuildDone;
           
              //  buildEvents.OnBuildDone -= OnBuildDone;
           
        }

        private void OnBuildBegin(vsBuildScope scope, vsBuildAction action)
        {
        }

        private void OnBuildDone(vsBuildScope scope, vsBuildAction action)
        {
        }
    }
}
