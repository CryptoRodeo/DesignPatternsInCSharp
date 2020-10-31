using bridge_pattern.abstract_implementor;
namespace bridge_pattern.concrete_implementor
{
  class IPTvService : IVideoSource
  {
    const string SOURCE_NAME = "IP TV";
    string IVideoSource.GetTvGuide()
    {
      return string.Format("Getting TV guide from - {0}", SOURCE_NAME);
    }
    string IVideoSource.PlayVideo()
    {
      return string.Format("Playing - {0}", SOURCE_NAME);
    }
  }
}