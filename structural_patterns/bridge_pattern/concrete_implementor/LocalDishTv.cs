using bridge_pattern.abstract_implementor;

namespace bridge_pattern.concrete_implementor
{
  public class LocalDishTv : IVideoSource
  {
    const string SOURCE_NAME = "Local Dish Tv";
    string IVideoSource.GetTvGuide()
    {
      return string.Format("Getting Tv Guide from - {0}", SOURCE_NAME);
    }
    string IVideoSource.PlayVideo()
    {
      return string.Format("Playing - {0}", SOURCE_NAME);
    }
  }
}