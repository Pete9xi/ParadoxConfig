using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.IO.Compression;

namespace ParadoxConfig
{
    public partial class Form1 : Form
    {
        private string extractedFilePath = "";
        private string downloadedFileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var selectedReleaseIndex = comboBoxReleases.SelectedIndex;
            if (selectedReleaseIndex >= 0)
            {
                var selectedRelease = comboBoxReleases.SelectedItem;
                var selectedSourceCodeZipUrl = $"https://github.com/Pete9xi/Paradox_AntiCheat/releases/download/{selectedRelease}/Paradox-AntiCheat-{selectedRelease}.mcpack";


                txtLog.AppendText(selectedSourceCodeZipUrl + Environment.NewLine);
                var downloadResult = await DownloadAndExtractFile(selectedSourceCodeZipUrl);
                if (downloadResult)
                {
                    txtLog.AppendText("Starting to create the pack." + Environment.NewLine);
                    createPack(textBox1.Text);
                  

                }
                else
                {
                    txtLog.AppendText("Download or extraction failed." + Environment.NewLine);
                }
            }
        }
        private async Task<bool> DownloadAndExtractFile(string fileUrl)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var fileName = Path.GetFileName(fileUrl);
                    var saveFilePath = Path.Combine(Application.StartupPath, fileName);
                    var fileBytes = await httpClient.GetByteArrayAsync(fileUrl);
                    File.WriteAllBytes(saveFilePath, fileBytes);

                    // Check if the file exists
                    if (File.Exists(saveFilePath))
                    {
                        txtLog.AppendText("File downloaded successfully." + Environment.NewLine);

                        // Rename the file extension from .mcpack to .zip
                        var newFileName = Path.ChangeExtension(saveFilePath, ".zip");
                        File.Move(saveFilePath, newFileName);
                        var selectedVersion = comboBoxReleases.SelectedItem.ToString();
                        var extractPath = Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{selectedVersion}/Paradox");
                        Directory.CreateDirectory(extractPath);

                        ZipFile.ExtractToDirectory(newFileName, extractPath);

                      txtLog.AppendText("File extracted successfully." + Environment.NewLine);
                        extractedFilePath = extractPath;
                        downloadedFileName = saveFilePath;
                        File.Delete(saveFilePath);
                        File.Delete(newFileName);
                        return true;
                    }
                    else
                    {
                        txtLog.AppendText("File download failed." + Environment.NewLine);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    txtLog.AppendText($"An error occurred during file download and extraction: {ex.Message}" + Environment.NewLine);
                    return false;
                }
            }
        }


        private void createPack(string password)
        {
            var selectedVersion = comboBoxReleases.SelectedItem.ToString();
            var extractPath = Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{selectedVersion}/Paradox");
            var outputFolderPath = Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{selectedVersion}");
            var outputFilePath = Path.Combine(outputFolderPath, $"Paradox-AntiCheat-{ selectedVersion}.zip");
            var prefix = txtPrefix.Text;
            var maxHomes = txtHomeAmount.Text;
            var HotbarMsg = txtHotBarMsg.Text;
            var rule1 = txtRule1.Text + '"';
            var rule2 = txtRule2.Text + '"';
            var rule3 = txtRule3.Text + '"';
            var rule4 = txtRule4.Text + '"';
            var rule5 = txtRule5.Text + '"';
            var banAppeal = txtBanAppeal.Text;
            Directory.CreateDirectory(outputFolderPath);

            // Update the settings in the config.js file
            var configFile = Path.Combine(extractPath, "scripts/data/config.js");
            string[] lines = File.ReadAllLines(configFile);
            for (int i = 0; i < lines.Length; i++)
            {

                if (lines[i].Contains("prefix: \"!\""))
                {
                    lines[i] = lines[i].Replace("prefix: \"!\"", $"prefix: \"{prefix}\"");
                }
                if (lines[i].Contains("password: \"\""))
                {
                    lines[i] = lines[i].Replace("password: \"\"", $"password: \"{password}\"");
                    break;
                }
                if (lines[i].Trim() == "setHome: {") { 
                for (int j = i + 1; j < lines.Length; j++)
                {
                    if (lines[j].Contains("max: "))
                     {
                        // Update the "max" property to your desired value
                        lines[j] = "            max: " + maxHomes + ",";
                        break; // Exit the inner loop after updating
                        }
                    }
                }
                if (lines[i].Contains("message: \"Hotbar is enabled (Set your message to change this)\""))
                {
                    lines[i] = lines[i].Replace("message: \"Hotbar is enabled (Set your message to change this)\"", $"message: \"{HotbarMsg}\"");
                }
                if (lines[i].Contains("Rule1: "))
                {
                    string[] parts = lines[i].Split(new string[] { "Rule1: " }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        lines[i] = parts[0] + "Rule1: " + rule1 + ",";
                    }
                }
                if (lines[i].Contains("Rule2: "))
                {
                    string[] parts = lines[i].Split(new string[] { "Rule2: " }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        lines[i] = parts[0] + "Rule2: " + rule2 + ",";
                    }
                }
                if (lines[i].Contains("Rule3: "))
                {
                    string[] parts = lines[i].Split(new string[] { "Rule3: " }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        lines[i] = parts[0] + "Rule3: " + rule3 + ",";
                    }
                }
                if (lines[i].Contains("Rule4: "))
                {
                    string[] parts = lines[i].Split(new string[] { "Rule4: " }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        lines[i] = parts[0] + "Rule4: " + rule4 + ",";
                    }
                }
                if (lines[i].Contains("Rule5: "))
                {
                    string[] parts = lines[i].Split(new string[] { "Rule5: " }, StringSplitOptions.None);

                    if (parts.Length == 2)
                    {
                        lines[i] = parts[0] + "Rule5: " + rule5 +",";
                    }
                }
                //discordLink:
                if (lines[i].Contains("discordLink: \"https://discord.gg\""))
                {
                    lines[i] = lines[i].Replace("discordLink: \"https://discord.gg\"", $"discordLink: \"{banAppeal}\"");
                }
            }
            File.WriteAllLines(configFile, lines);

            txtLog.AppendText("File updated successfully." + Environment.NewLine);

            // Create the ZIP file with the desired folder structure
            using (var zipArchive = ZipFile.Open(outputFilePath, ZipArchiveMode.Create))
            {
                var files = Directory.GetFiles(extractPath, "*", SearchOption.AllDirectories);
                foreach (var filePath in files)
                {
                    var relativePath = Path.Combine("Paradox", filePath.Substring(extractPath.Length + 1));
                    zipArchive.CreateEntryFromFile(filePath, relativePath, CompressionLevel.Optimal);
                }
            }
            //Once the Zip has been created rename it to .mcpack and move it to the root folder of the application. then cleanup.
            txtLog.AppendText("Files re-zipped successfully." + Environment.NewLine);
            var saveFilePath = Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{selectedVersion}/Paradox-AntiCheat-{selectedVersion}.zip");
            var newFileName = Path.ChangeExtension(saveFilePath, ".mcpack");
            File.Move(saveFilePath, newFileName);
            var finalePack = Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{selectedVersion}/Paradox-AntiCheat-{selectedVersion}.mcpack");
            var applicationDir = Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{ selectedVersion}.mcpack");
            File.Move(finalePack, applicationDir);
            txtLog.AppendText("The pack has been created with the requested password, this can now be imported." +Environment.NewLine);
            Directory.Delete(Path.Combine(Application.StartupPath, $"Paradox-AntiCheat-{selectedVersion}"),true);
        }
        private void comboBoxReleases_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Paradox_AntiCheat", "1"));
            var repo = "Pete9xi/Paradox_AntiCheat";
            var releasesUrl = $"https://api.github.com/repos/{repo}/releases";
            var releasesJson = await httpClient.GetStringAsync(releasesUrl);
            var releases = JsonConvert.DeserializeObject<JArray>(releasesJson);
            foreach (var release in releases)
            {
                var releaseName = (string)release["name"];
                comboBoxReleases.Items.Add(releaseName);
            }
        }
        



    }
}

