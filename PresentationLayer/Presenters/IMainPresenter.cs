using System;

namespace PresentationLayer.Presenters
{
    public interface IMainPresenter
    {
        event EventHandler UserDetailViewBindingDoneEventRaised;

        IMainView GetMainView();
    }
}