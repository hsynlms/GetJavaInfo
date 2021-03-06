﻿using System;
using System.Runtime.InteropServices;

namespace GetJavaInfo
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("021BCE75-E82D-4147-AC30-AE16FE5AF912")]
    [ComVisible(true)]
    public class General
    {
        public static string CurrentJavaVersion()
        {
            try
            {
                return Methods.GetJavaInformation(Types.DataType.Version);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string CurrentJavaPath()
        {
            try
            {
                return Methods.GetJavaInformation(Types.DataType.Path);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string WasItInstalled(string version)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(version))
                {
                    return Methods.GetJavaInformation(Types.DataType.Path, version);
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string[] GetAllVersion()
        {
            try
            {
                return Methods.GetAllJavaList(Types.DataType.Version);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string[] GetAllPath()
        {
            try
            {
                return Methods.GetAllJavaList(Types.DataType.Path);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
