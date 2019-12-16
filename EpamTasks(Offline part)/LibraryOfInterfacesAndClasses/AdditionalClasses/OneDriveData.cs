using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Microsoft.OneDrive.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfInterfacesAndClasses.AdditionalClasses
{
    public class OneDriveData : IWriteReadable
    {
        public object Read()
        {
            throw new NotImplementedException();
        }


        // not yet implemented
        public void Write(object data)
        {
            //string[] scopes = { "wl.signin", "onedrive.readwrite" };
            //IOneDriveClient _client = OneDriveClientExtensions.GetClientUsingOnlineIdAuthenticator(scopes);
            //AccountSession acse = await _client.AuthenticateAsync();

            //if (!_client.IsAuthenticated) return;

            //FileOpenPicker fileOpenPicker = new FileOpenPicker();
            //fileOpenPicker.FileTypeFilter.Add(".jpg");
            //StorageFile file = await fileOpenPicker.PickSingleFileAsync();

            //if (file != null)
            //{
            //    using (Stream contentStream = await file.OpenStreamForReadAsync())
            //    {
            //        var uploadedItem = await _client
            //                                     .Drive
            //                                     .Root
            //                                     .ItemWithPath("CodeExamples/" + file.Name)
            //                                     .Content
            //                                     .Request()
            //                                     .PutAsync<Item>(contentStream);
            //    }
            //}
        }
    }
}
