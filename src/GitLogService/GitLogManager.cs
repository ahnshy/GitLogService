using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLogService
{
    class GitLogManager
    {
        public void GetLog(ref Dictionary<string, int> dictonary)
        {
            string repositoryPath = @"F:\Git\V-Ceph";
            //string gitLogCommand = "git log --pretty=format:\"%h %an %s %ad\" --date=short"; // // 개인별 통계 + 해쉬
            //string gitLogCommand = "git log --date=format:\"%Y-%m-%d\" --pretty=\"%ad : %s\" --since=\"2024-01-01\" --before=\"2024-12-31\" --no-merges"; // 개인별 통계
            string gitLogCommand = "git shortlog -sn --no-merges --since=\"2024-01-01\"";

            string output = RunGitCommand(repositoryPath, gitLogCommand);
            string[] lines = output.Split('\n');
            foreach (string line in lines)
            {
                string[] items = line.Split('\t');
                if (items.Length <= 1 || string.IsNullOrEmpty(items[1].Trim()))
                    continue;

                dictonary.Add(items[1].Trim(), Int32.Parse(items[0].Trim()));
            }
        }

        static string RunGitCommand(string workingDirectory, string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd {workingDirectory} && {command}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
