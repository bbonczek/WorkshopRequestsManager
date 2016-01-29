﻿using System;
using System.Collections.Generic;
using WorkshopManager.DatabasePresenter;

namespace WorkshopManager.Forms.RequestsDatabaseView
{
    public class RequestsDatabasePresenter
    {
        private IRequestsDatabaseView _view;
        private IRequestDatabaseAdapter _dataBase;

        public RequestsDatabasePresenter(IRequestsDatabaseView view)
        {
            _view = view;
            _view.Presenter = this;
            _dataBase = new DatabasePresenter.DatabasePresenter();

            Init();
        }

        public void Init()
        {
            SetActiveComboBoxDataSource();
            //LoadRequestDataToDataGridView();
        }

        private void LoadRequestDataToDataGridView()
        {
            List<Request> requests = _dataBase.GetAll();
        }

        public void OpenModifierFormForAdding()
        {
            var requestsModifierForm = new RequestsModifierView.RequestsModifierView();
            requestsModifierForm.ShowDialog();
        }

        public void OpenModifierFormForEditing()
        {
            var requestsModifierForm = new RequestsModifierView.RequestsModifierView("dsfdsf"); //bedzie przesylana struktura z informacjami o requescie
            requestsModifierForm.ShowDialog();
        }

        private void SetActiveComboBoxDataSource()
        {
            _view.ActiveDataComboBox = Enum.GetValues(typeof(RequestsCategory));
        }

        
    }
}
