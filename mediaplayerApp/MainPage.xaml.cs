using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Runtime.InteropServices.WindowsRuntime;

using Windows.Foundation;

using Windows.Foundation.Collections;

using Windows.UI.Xaml;

using Windows.UI.Xaml.Controls;

using Windows.UI.Xaml.Controls.Primitives;

using Windows.UI.Xaml.Data;

using Windows.UI.Xaml.Input;

using Windows.UI.Xaml.Media;

using Windows.UI.Xaml.Navigation;

using Windows.Media.MediaProperties;

using Windows.Media.Core;

using Windows.Media.Playback;

using System.Threading.Tasks;

using Windows.Media.Streaming.Adaptive;

using Windows.Storage;

using Windows.Storage.Streams;

using System.Security.Cryptography;





// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409



namespace mediaplayerApp

{

    /// <summary>

    /// An empty page that can be used on its own or navigated to within a Frame.

    /// </summary>

    public sealed partial class MainPage : Page

    {

        public MainPage()

        {

            this.InitializeComponent();

        }



        private void button_Click(object sender, RoutedEventArgs e)

        {

            this.Frame.Navigate(typeof(Playmusic));

        }









        /* async public static Task asyncopenFile( string content, string FileName)

         {



             var savePicker = new Windows.Storage.Pickers.FileSavePicker();

             savePicker.SuggestedStartLocation =

                 Windows.Storage.Pickers.PickerLocationId.MusicLibrary;

             // Dropdown of file types the user can save the file as

             savePicker.FileTypeChoices.Add("mysong", new List<string>() { ".mp3" });

             // Default file name if the user does not type one in or select a file to replace

             savePicker.SuggestedFileName = "New Music";



             Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();

             if (file != null)

             {

                 // Prevent updates to the remote version of the file until

                 // we finish making changes and call CompleteUpdatesAsync.

                 Windows.Storage.CachedFileManager.DeferUpdates(file);

                 // write to file

                 await Windows.Storage.FileIO.WriteTextAsync(file, file.Name );



                 Windows.Storage.Provider.FileUpdateStatus status =

                     await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);



             }

         }*/



        /*  async private Task SetLocalMedia()

          {

              var _mediaPlayer = new Windows.Media.Playback.MediaPlayer();

              var openPicker = new Windows.Storage.Pickers.FileOpenPicker();



              openPicker.FileTypeFilter.Add(".wmv");

              openPicker.FileTypeFilter.Add(".mp4");

              openPicker.FileTypeFilter.Add(".wma");

              openPicker.FileTypeFilter.Add(".mp3");



              var newfile = await openPicker.PickSingleFileAsync();



              if (newfile != null)

              {



                  _mediaPlayer.Source = MediaSource.CreateFromStorageFile(newfile);



                  _mediaPlayer.Play();

              }

          }



          async private void Button_Click(object sender, RoutedEventArgs e)

          {

              await SetLocalMedia();

          }



          async private void Button_Click2(object sender, RoutedEventArgs e)

          {

              string uri = txtFilePath.Text;

              await asyncopenFile(uri,@"C:/ Users/ sewi/ Music");

          }   */



    }



}



