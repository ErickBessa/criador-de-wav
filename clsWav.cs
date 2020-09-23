using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CWav
{
    public class clsWav
    {
        //-------------https://www.codeproject.com/articles/129173/writing-a-proper-wave-file---------------// Credits.
        static byte[] RIFF_HEADER = new byte[] { 0x52, 0x49, 0x46, 0x46 };
        static byte[] FORMAT_WAVE = new byte[] { 0x57, 0x41, 0x56, 0x45 };
        static byte[] FORMAT_TAG = new byte[] { 0x66, 0x6d, 0x74, 0x20 };
        static byte[] AUDIO_FORMAT = new byte[] { 0x01, 0x00 };
        static byte[] SUBCHUNK2_ID = new byte[] { 0x64, 0x61, 0x74, 0x61 };
        private const int BYTES_PER_SAMPLE = 2;
        //private const int iBitsPerSample = 16;

        private static byte[] CreateSinWave(int iSampleRate, double frequency, TimeSpan length, double magnitude)
        {
            int iSampleCount = (int)(((double)iSampleRate) * length.TotalSeconds);
            short[] bTempBuffer = new short[iSampleCount];
            byte[] bRetVal = new byte[iSampleCount * 2];
            double step = Math.PI * 2.0d / frequency;
            double current = 0;

            for (int i = 0; i < bTempBuffer.Length; ++i)
            {
                bTempBuffer[i] = (short)(Math.Sin(current) * magnitude * ((double)short.MaxValue));
                current += step;
            }

            Buffer.BlockCopy(bTempBuffer, 0, bRetVal, 0, bRetVal.Length);
            return bRetVal;
        }

        public static byte[] CreateSin(double iVolume = 32767, double iFrequence = 400, int iTempoSeg = 8)
        {
            try
            {
                double iAmpliPositiva = 32768.0;
                double iTempo = 0.00012; //1s
                double iW = Math.PI * 2.0 * iFrequence;
                int iSampleRate = 8000;
                byte[] bDataWave = new byte[iTempoSeg * iSampleRate * 2];
                int iPos = 0;
                for (int i = 0; i < iTempoSeg * iSampleRate; i++)
                {
                    double iResultado = iAmpliPositiva + iVolume * Math.Sin(iW * iTempo * (i + 1));
                    byte[] bByte = clsWav.PackageInt((int)iResultado, 2);
                    //Array.Reverse(bByte);
                    Array.Copy(bByte, 0, bDataWave, iPos, bByte.Length);
                    iPos += bByte.Length;
                }
                return bDataWave;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro(CreateSin): " + ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }


        private static void WriteHeader(Stream targetStream, Int32 byteStreamSize, bool bMono)
        {
            try
            {
                int channelCount = 2;
                if (bMono)
                    channelCount = 1;

                int sampleRate = 8000;
                int byteRate = sampleRate * channelCount * BYTES_PER_SAMPLE;
                int blockAlign = channelCount * BYTES_PER_SAMPLE;

                targetStream.Write(RIFF_HEADER, 0, RIFF_HEADER.Length); //Riff
                targetStream.Write(PackageInt(byteStreamSize + 36, 4), 0, 4); //ChunkSize

                targetStream.Write(FORMAT_WAVE, 0, FORMAT_WAVE.Length); //Format
                targetStream.Write(FORMAT_TAG, 0, FORMAT_TAG.Length);//SubChunkID
                targetStream.Write(PackageInt(16, 4), 0, 4);//Subchunk1Size    

                targetStream.Write(AUDIO_FORMAT, 0, AUDIO_FORMAT.Length);//AudioFormat   
                targetStream.Write(PackageInt(channelCount, 2), 0, 2); //Number of Channels
                targetStream.Write(PackageInt(sampleRate, 4), 0, 4); //SampleRate
                targetStream.Write(PackageInt(byteRate, 4), 0, 4); //Bytes per Sample
                targetStream.Write(PackageInt(blockAlign, 2), 0, 2); //BlockAlign
                targetStream.Write(PackageInt(BYTES_PER_SAMPLE * 8), 0, 2); //Bits Per Sample
                //targetStream.Write(PackageInt(0,2), 0, 2);//Extra param size
                targetStream.Write(SUBCHUNK2_ID, 0, SUBCHUNK2_ID.Length);
                targetStream.Write(PackageInt(byteStreamSize, 4), 0, 4); //SubChuck2Size
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro(WriteHeader): " + ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static byte[] PackageInt(int source, int length = 2)
        {
            if ((length != 2) && (length != 4))
                throw new ArgumentException("length must be either 2 or 4", "length");
            var retVal = new byte[length];
            retVal[0] = (byte)(source & 0xFF);
            retVal[1] = (byte)((source >> 8) & 0xFF);
            if (length == 4)
            {
                retVal[2] = (byte)((source >> 0x10) & 0xFF);
                retVal[3] = (byte)((source >> 0x18) & 0xFF);
            }
            return retVal;
        }

        public static bool CreateFileWav(byte[] bSoundData, bool bMono)
        {
            try
            {
                if (bSoundData != null)
                {
                    //var soundData = CreateSinWave(44000, 120, TimeSpan.FromSeconds(60), 1d);
                    string sDateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    using (FileStream fs = new FileStream(sDateTime + ".wav", FileMode.Create))
                    {
                        WriteHeader(fs, bSoundData.Length, bMono);
                        fs.Write(bSoundData, 0, bSoundData.Length);
                        fs.Close();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro(CreateFileWav): " + ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void PlaySimpleSound(string sFileWav)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(sFileWav);
                simpleSound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro(PlaySimpleSound): " + ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}