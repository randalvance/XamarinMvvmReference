using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using XamarinMvvmReference.Services;

namespace XamarinMvvmReference.Mvvm.Core.ViewModels
{
    public class PersonListViewModel : MvxViewModel
    {
        private IEnumerable<PersonListItem> items;

        private readonly IPersonService personService;

        public PersonListViewModel(IPersonService personService)
        {
            this.personService = personService;
        }

        public override void Start()
        {
            base.Start();

            items = personService.ListAll().Select(p => new PersonListItem(this, $"{p.FirstName} {p.LastName}", p.PersonId));
        }

        public IEnumerable<PersonListItem> Items
        {
            get { return items; }
            set
            {
                items = value;
                RaisePropertyChanged(() => items);
            }
        }

        public class PersonListItem
        {
            private PersonListViewModel parent;
            private Guid entityId;

            public PersonListItem(PersonListViewModel parent, string title, Guid entityId)
            {
                Title = title;

                this.entityId = entityId;
                this.parent = parent;

                ShowCommand = new MvxCommand(OnShowCommand);
            }

            private void OnShowCommand()
            {
                MvxBundle bundle = new MvxBundle();
                bundle.Data["entityId"] = entityId.ToString();

                parent.ShowViewModel<PersonViewModel>(bundle);
            }

            public string Title { get; set; }

            public ICommand ShowCommand { get; set; }
        }
    }
}
