using System.Diagnostics;
using System.Security.AccessControl;

namespace FileViewer
{
    public partial class MainForm : Form
    {
        public string[] notAccess = { "$RECYCLE.BIN",
                                      "Config.Msi",
                                      "Documents and Settings",
                                      "System Volume Information" };
        public string curPath = @"C:\\";
        public TreeNode curNode = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitDisplay();
        }

        public void InitDisplay()
        {
            tvDirectory.Nodes.Clear();
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (DriveInfo info in driveInfos)
            {
                TreeNode node = new()
                {
                    Tag = info.Name,
                    Text = info.DriveType + " (" + info.Name.Split('\\')[0] + ")",
                    ImageIndex = 0,
                    SelectedImageIndex = 0
                };

                tvDirectory.Nodes.Add(node);
            }
            curPath = driveInfos[0].Name;

            foreach (TreeNode node in tvDirectory.Nodes)
            {
                LoadChildNodes(node);
            }
        }

        public void LoadChildNodes(TreeNode root)
        {
            try
            {
                root.Nodes.Clear();
                DirectoryInfo directoryInfo = new(root.Tag.ToString());
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

                foreach (DirectoryInfo info in directoryInfos)
                {
                    if (notAccess.Contains(info.Name)) continue;
                    TreeNode node = new()
                    {
                        Text = info.Name,
                        Tag = info.FullName,
                        ImageIndex = 1,
                        SelectedImageIndex = 1
                    };
                    root.Nodes.Add(node);
                    node.Nodes.Add("");
                }
            }
            catch { }
        }

        public void LoadFilesList(string path)
        {
            tstbPath.Text = path;
            lvFiles.BeginUpdate();
            lvFiles.Items.Clear();
            try
            {
                DirectoryInfo directoryInfo = new(path);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (DirectoryInfo dirInfo in directoryInfos)
                {
                    if (notAccess.Contains(dirInfo.Name)) continue;
                    ListViewItem item = new(dirInfo.Name, 1);
                    item.Tag = dirInfo.FullName;
                    item.SubItems.Add(dirInfo.LastWriteTime.ToString());
                    item.SubItems.Add("文件夹");
                    item.SubItems.Add("");
                    lvFiles.Items.Add(item);
                }

                foreach (FileInfo fileInfo in fileInfos)
                {
                    ListViewItem item = new(fileInfo.Name);
                    item.Tag = fileInfo.FullName;
                    item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                    item.SubItems.Add(fileInfo.Extension.Replace(".", ""));
                    item.SubItems.Add(ShowFileSize(fileInfo.Length).Split('(')[0]);
                    lvFiles.Items.Add(item);
                }
            }
            catch { }

            tsslFilesNum.Text = lvFiles.Items.Count + "个项目";
            lvFiles.EndUpdate();
        }

        public static string ShowFileSize(long fileSize)
        {
            string fileSizeStr = "";

            if (fileSize < 1024)
            {
                fileSizeStr = fileSize + " 字节";
            }
            else if (fileSize >= 1024 && fileSize < 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / 1024, 2, MidpointRounding.AwayFromZero) + " KB(" + fileSize + "字节)";
            }
            else if (fileSize >= 1024 * 1024 && fileSize < 1024 * 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024), 2, MidpointRounding.AwayFromZero) + " MB(" + fileSize + "字节)";
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024 * 1024), 2, MidpointRounding.AwayFromZero) + " GB(" + fileSize + "字节)";
            }

            return fileSizeStr;
        }

        private void tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            curNode = e.Node;
            curPath = curNode.Tag.ToString();
            LoadFilesList(curPath);
        }

        private void tvDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            LoadChildNodes(e.Node);
        }

        private void lvFiles_ItemActivate(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count > 0)
            {
                string path = lvFiles.SelectedItems[0].Tag.ToString();
                string type = lvFiles.SelectedItems[0].SubItems[2].Text;
                
                try
                {
                    if (Directory.Exists(path))
                    {
                        LoadFilesList(path);
                    }
                    else if (type == "txt")
                    {
                        
                        Process.Start("notepad.exe", path);
                    }
                    else
                    {
                        Process.Start(path);
                    }
                }
                catch { }
            }
        }
    }
}