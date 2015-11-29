﻿// FFXIVAPP.Plugin.Widgets
// EnmityWidgetViewModel.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met: 
// 
//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution. 
//  * Neither the name of SyndicatedLife nor the names of its contributors may 
//    be used to endorse or promote products derived from this software 
//    without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE. 

using System.ComponentModel;
using System.Runtime.CompilerServices;
using FFXIVAPP.Memory.Core;

namespace FFXIVAPP.Plugin.Widgets.Windows
{
    internal sealed class EnmityWidgetViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static EnmityWidgetViewModel _instance;
        private float _enmityTargetDistance;
        private double _enmityTargetHPPercent;
        private bool _enmityTargetIsValid;
        private TargetEntity _targetEntity;

        public static EnmityWidgetViewModel Instance
        {
            get { return _instance ?? (_instance = new EnmityWidgetViewModel()); }
        }

        public TargetEntity TargetEntity
        {
            get { return _targetEntity ?? (_targetEntity = new TargetEntity()); }
            set
            {
                _targetEntity = value;
                RaisePropertyChanged();
            }
        }

        public bool EnmityTargetIsValid
        {
            get { return _enmityTargetIsValid; }
            set
            {
                _enmityTargetIsValid = value;
                RaisePropertyChanged();
            }
        }

        public double EnmityTargetHPPercent
        {
            get { return _enmityTargetHPPercent; }
            set
            {
                _enmityTargetHPPercent = value;
                RaisePropertyChanged();
            }
        }

        public float EnmityTargetDistance
        {
            get { return _enmityTargetDistance; }
            set
            {
                _enmityTargetDistance = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Declarations

        #endregion

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Command Bindings

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
