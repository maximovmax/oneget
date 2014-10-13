// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace Microsoft.OneGet.PackageProvider.Test {
    using System;
    using System.Collections.Generic;
    using global::OneGet.ProviderSDK;
    using IRequestObject = System.Object;

    public class TestPackageProvider {
        #region implement PackageProvider-interface

        public void AddPackageSource(string name, string location, bool trusted, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'AddPackageSource'" );
            }

        }
        public bool FindPackage(string name, string requiredVersion, string minimumVersion, string maximumVersion, int id, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'FindPackage'" );
            }

            return  default(bool);
        }
        public bool FindPackageByFile(string file, int id, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'FindPackageByFile'" );
            }

            return  default(bool);
        }
        public bool FindPackageByUri(Uri uri, int id, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'FindPackageByUri'" );
            }

            return  default(bool);
        }
        public bool GetInstalledPackages(string name, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'GetInstalledPackages'" );
            }

            return  default(bool);
        }
        public void GetDynamicOptions(string category, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'GetDynamicOptions'" );
            }

        }

        /// <summary>
            /// Returns the name of the Provider. 
            /// </summary>
            /// <returns></returns>
        public string GetPackageProviderName(){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.

            return "TestPackageProvider";
        }
        public bool ResolvePackageSources(IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'ResolvePackageSources'" );
            }

            return  default(bool);
        }
        public void InitializeProvider(IRequestObject requestObject) {
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug( "Calling 'InitializeProvider'");
            }
        }
        public bool InstallPackage(string fastPath, IRequestObject requestObject) {
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'InstallPackage'" );
            }

            return  default(bool);
        }

        // WhatIfInstallPackageBy* should be a good idea to fix -WhatIf
        public bool InstallPackageByFile(string filePath, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'InstallPackageByFile'" );
            }

            return  default(bool);
        }
        public bool InstallPackageByUri(string u, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'InstallPackageByUri'" );
            }

            return  default(bool);
        }
        public bool IsTrustedPackageSource(string packageSource, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'IsTrustedPackageSource'" );
            }

            return  default(bool);
        }
        public bool IsValidPackageSource(string packageSource, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'IsValidPackageSource'" );
            }

            return  default(bool);
        }
        public void RemovePackageSource(string name, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'RemovePackageSource'" );
            }

        }
        public bool UninstallPackage(string fastPath, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'UninstallPackage'" );
            }

            return  default(bool);
        }
        public void GetFeatures(IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'GetFeatures'" );
            }

        }

        // --- operations on a package ---------------------------------------------------------------------------------------------------
        public bool DownloadPackage(string fastPath, string location, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'DownloadPackage'" );
            }

            return  default(bool);
        }
        public bool GetPackageDependencies(string fastPath, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'GetPackageDependencies'" );
            }

            return  default(bool);
        }
        public bool GetPackageDetails(string fastPath, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'GetPackageDetails'" );
            }

            return  default(bool);
        }
        public int StartFind(IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'StartFind'" );
            }

            return  default(int);
        }
        public bool CompleteFind(int id, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request =requestObject.As<Request>()) {
                // use the request object to interact with the OneGet core:
                request.Debug("Calling 'CompleteFind'" );
            }

            return  default(bool);
        }

                // --- Optimization features -----------------------------------------------------------------------------------------------------
        public bool GetIsSourceRequired(){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.

            return  default(bool);
        }
        public void ExecuteElevatedAction(string payload, IRequestObject requestObject){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.

        }

        #endregion

    }

}