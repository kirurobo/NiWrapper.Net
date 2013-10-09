﻿/*
    Copyright (C) 2013 Soroush Falahati - soroush@falahati.net

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
	*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NiTEWrapper
{
    public class HandData : NiTEBase
    {
        internal HandData(IntPtr handle)
        {
            this.Handle = handle;
        }

        [DllImport("NiWrapper.NiTE.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void HandData_getPosition(IntPtr objectHandler,
            ref float x, ref float y, ref float z);
        object _Position;
        public Point3D Position
        {
            get
            {
                if (_Position == null)
                {
                    float x = 0, y = 0, z = 0;
                    HandData_getPosition(this.Handle, ref x, ref y, ref z);
                    _Position = new Point3D(x, y, z);
                }
                return (Point3D)_Position;
            }
        }

        [DllImport("NiWrapper.NiTE.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern short HandData_getId(IntPtr objectHandler);
        short? _HandId;
        public short HandId
        {
            get
            {
                if (_HandId == null)
                    _HandId = HandData_getId(this.Handle);
                return _HandId.Value;
            }
        }

        [DllImport("NiWrapper.NiTE.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool HandData_isLost(IntPtr objectHandler);
        bool? _isLost;
        public bool isLost
        {
            get
            {
                if (_isLost == null)
                    _isLost = HandData_isLost(this.Handle);
                return _isLost.Value;
            }
        }

        [DllImport("NiWrapper.NiTE.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool HandData_isNew(IntPtr objectHandler);
        bool? _isNew;
        public bool isNew
        {
            get
            {
                if (_isNew == null)
                    _isNew = HandData_isNew(this.Handle);
                return _isNew.Value;
            }
        }

        [DllImport("NiWrapper.NiTE.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool HandData_isTouchingFov(IntPtr objectHandler);
        bool? _isTouchingFov;
        public bool isTouchingFov
        {
            get
            {
                if (_isTouchingFov == null)
                    _isTouchingFov = HandData_isTouchingFov(this.Handle);
                return _isTouchingFov.Value;
            }
        }

        [DllImport("NiWrapper.NiTE.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool HandData_isTracking(IntPtr objectHandler);
        bool? _isTracking;
        public bool isTracking
        {
            get
            {
                if (_isTracking == null)
                    _isTracking = HandData_isTracking(this.Handle);
                return _isTracking.Value;
            }
        }

    }
}
