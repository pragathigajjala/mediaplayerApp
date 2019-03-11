using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Runtime.InteropServices.WindowsRuntime;

using Windows.Foundation;

using Windows.Foundation.Collections;

using Windows.Media.Editing;

using Windows.Storage;

using Windows.Storage.Pickers;

using Windows.UI.Xaml;

using Windows.UI.Xaml.Controls;

using Windows.UI.Xaml.Controls.Primitives;

using Windows.UI.Xaml.Data;

using Windows.UI.Xaml.Input;

using Windows.UI.Xaml.Media;

using Windows.UI.Xaml.Media.Imaging;

using Windows.UI.Xaml.Navigation;

using Windows.UI.Popups;

using System.Collections.ObjectModel;

using Windows.UI.Xaml.Controls.Maps;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238



namespace mediaplayerApp

{

    /// <summary>

    /// An empty page that can be used on its own or navigated to within a Frame.

    /// </summary>

    public sealed partial class AddMusic : Page

    {

        private MediaComposition _mediacomposition;

        public AddMusic()

        {

            this.InitializeComponent();

        }



        private async void Musiclistalbumpicture(object sender, TappedRoutedEventArgs e)

        {

            FileOpenPicker openPicker = new FileOpenPicker();

            openPicker.ViewMode = PickerViewMode.Thumbnail;

            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;

            openPicker.FileTypeFilter.Add(".Jpg");

            openPicker.FileTypeFilter.Add(".png");

            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)

            {

                var stream = await file.OpenAsync(FileAccessMode.Read);

                var Image = new BitmapImage();

                Image.SetSource(stream);

                imageplace.Children.Add(new Image() { Source = Image, Width = 200, Height = 200 });

            }

        }

        private ObservableCollection<CollectionOfmusic> MusicList = new ObservableCollection<CollectionOfmusic>();

        private void MusiclistView_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {



        }



        private void Cancelbtn_Click(object sender, RoutedEventArgs e)

        {

            var message = new MessageDialog("Are you sure you want to cancel the play list?").ShowAsync();

        }



        private async void Btnselect_Click(object sender, RoutedEventArgs e)

        {

            FileOpenPicker fileOpenPicker = new FileOpenPicker();

            fileOpenPicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;

            fileOpenPicker.FileTypeFilter.Add(".mp3");

            fileOpenPicker.FileTypeFilter.Add(".mp4");

            StorageFile storagefile0 = await fileOpenPicker.PickSingleFileAsync();

            if (storagefile0 != null)

            {

                var musicproperties = await storagefile0.Properties.GetMusicPropertiesAsync();

                var musicname = musicproperties.Title;

                var musicartist = musicproperties.Artist;



                var title = musicproperties.Title;

                if (title == "")

                {

                    title = "unknown music title";

                }

                var album = musicproperties.Album;

                if (album == "")

                {

                    album = "unknown music album";

                }

                MusicList.Add(new CollectionOfmusic

                {

                    Title = title,

                    Artist = musicartist,

                    Album = album



                });

            }

        }



        private async void Creatbtn_Click(object sender, RoutedEventArgs e)

        {

            if (!string.IsNullOrEmpty(musicselectiontextBox.Text))

            {

                _mediacomposition = new MediaComposition();

                FileSavePicker fileSavePicker = new FileSavePicker();

                fileSavePicker.SuggestedStartLocation = PickerLocationId.Downloads;

                fileSavePicker.FileTypeChoices.Add("Wpl", new List<string>() { ".Wpl" });

                fileSavePicker.FileTypeChoices.Add("zpl", new List<string>() { ".zpl" });

                fileSavePicker.FileTypeChoices.Add("m3u", new List<string>() { ".m3u" });



                StorageFile pickedFile = await fileSavePicker.PickSaveFileAsync();

                StorageFolder folder = KnownFolders.MusicLibrary;

                if (pickedFile != null)

                {



                    musiclistView.IsEnabled = true;



                }

            }

        }



        private void Browsebutton_Click(object sender, RoutedEventArgs e)

        {

        }

    }

}