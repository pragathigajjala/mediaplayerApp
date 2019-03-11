using System;

using System.Collections.Generic;

using System.Collections.ObjectModel;

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

using Windows.Storage;

using Windows.Storage.FileProperties;

using Windows.UI.Xaml.Media.Imaging;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238



namespace mediaplayerApp

{

    /// <summary>

    /// An empty page that can be used on its own or navigated to within a Frame.

    /// </summary>

    public sealed partial class MyMusicList : Page

    {

        private ObservableCollection<CollectionOfmusic> musicList = new ObservableCollection<CollectionOfmusic>();

        public MyMusicList()

        {

            this.InitializeComponent();

        }



        protected override async void OnNavigatedTo(NavigationEventArgs e)

        {

            StorageFolder musiclibrary = KnownFolders.MusicLibrary;

            var files = await musiclibrary.GetFilesAsync();



            foreach (var file in files)

            {

                StorageItemThumbnail currrentthumbnail = await file.GetThumbnailAsync

                    (Windows.Storage.FileProperties.ThumbnailMode.MusicView, 30, ThumbnailOptions.UseCurrentScale);

                var albumpicture = new BitmapImage();

                albumpicture.SetSource(currrentthumbnail);



                var musicProperties = await file.Properties.GetMusicPropertiesAsync();

                var musicname = musicProperties.Title;

                var musicalbum = musicProperties.Album;

                var title = musicProperties.Title;

                if (title == "")

                {

                    title = " unknown Title";



                }

                var artist = musicProperties.Artist;

                if (artist == "")

                {

                    artist = "unknown Artist";

                }



                var album = musicProperties.Album;

                if (album == "")

                {

                    album = "Unknown Album";

                }



                musicList.Add(new CollectionOfmusic

                {
                    Title = title,

                    Artist = artist,

                    Album = album,

                    Albumpicture = albumpicture



                });

            }



        }

    }

}