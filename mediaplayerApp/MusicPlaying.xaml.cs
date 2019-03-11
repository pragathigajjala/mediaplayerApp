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

using Windows.Media;

using System.Threading;

using Windows.Storage.Pickers;

using Windows.Storage;

using Windows.Storage.Streams;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238



namespace mediaplayerApp

{

    /// <summary>

    /// An empty page that can be used on its own or navigated to within a Frame.

    /// </summary>

    public sealed partial class MusicPlaying : Page

    {



        public MusicPlaying()

        {

            this.InitializeComponent();

        }



        private async void openfile_Click(object sender, RoutedEventArgs e)

        {

            FileOpenPicker openPicker = new FileOpenPicker();

            openPicker.ViewMode = PickerViewMode.Thumbnail;

            openPicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;

            openPicker.FileTypeFilter.Add(".Mp3");

            openPicker.FileTypeFilter.Add(".Mp4");



            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)

            {

                IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read);



                mediaElement.SetSource(stream, file.ContentType);

                mediaElement.Play();

            }



        }



        private void Back0_Click(object sender, RoutedEventArgs e)

        {

            this.Frame.Navigate(typeof(Playmusic));

        }

        private void play_Click(object sender, RoutedEventArgs e)

        {



            if (mediaElement.DefaultPlaybackRate != 1)

            {

                mediaElement.DefaultPlaybackRate = 1.0;

            }

            mediaElement.Play();

        }



        private void Pause_Click(object sender, RoutedEventArgs e)

        {

            mediaElement.Pause();

        }



        private void Stop_Click(object sender, RoutedEventArgs e)

        {

            mediaElement.Stop();

        }



        private void Back_Click(object sender, RoutedEventArgs e)

        {

            mediaElement.DefaultPlaybackRate = -2.0;

            mediaElement.Play();

        }



        private void Forward_Click(object sender, RoutedEventArgs e)

        {

            mediaElement.DefaultPlaybackRate = 2.0;

            mediaElement.Play();



        }



        private void Mute_Click(object sender, RoutedEventArgs e)

        {

            mediaElement.IsMuted = true;

        }



        private void VolumePlus_Click(object sender, RoutedEventArgs e)

        {



        }



        private void VolumeMinus_Click(object sender, RoutedEventArgs e)

        {



        }



        private void SeekToMediaPosition(object sender, RangeBaseValueChangedEventArgs e)

        {



        }

    }

}