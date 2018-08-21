﻿/*
 * Copyright 2018 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : Server Shell
 * Summary  : Provides access to the Server shell
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2018
 * Modified : 2018
 */

using Scada.UI;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scada.Server.Shell.Code
{
    /// <summary>
    /// Provides access to the Server shell.
    /// <para>Обеспечивает доступ к оболочке Сервера.</para>
    /// </summary>
    public class ServerShell
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ServerShell()
        {
        }


        /// <summary>
        /// Gets the images used by the explorer.
        /// </summary>
        public ICollection<object> GetTreeViewImages()
        {
            return null;
        }

        /// <summary>
        /// Gets the tree nodes for the explorer.
        /// </summary>
        public TreeNode[] GetTreeNodes(Settings settings)
        {
            return new TreeNode[]
            {
                new TreeNode(ServerShellPhrases.CommonParamsNode)
                {
                    ImageKey = "server_params.png",
                    SelectedImageKey = "server_params.png",
                    Tag = new TreeNodeTag()
                    {
                        FormType = null,
                        FormArgs = new object[] { settings }
                    }
                },
                new TreeNode(ServerShellPhrases.SaveParamsNode)
                {
                    ImageKey = "server_save.png",
                    SelectedImageKey = "server_save.png",
                    Tag = new TreeNodeTag()
                    {
                        FormType = null,
                        FormArgs = new object[] { settings }
                    }
                },
                new TreeNode(ServerShellPhrases.ArchiveNode, 
                    new TreeNode[] 
                    {
                        new TreeNode(ServerShellPhrases.CurDataNode)
                        {
                            ImageKey = "server_data.png",
                            SelectedImageKey = "server_data.png",
                            Tag = new TreeNodeTag()
                            {
                                FormType = null,
                                FormArgs = null
                            }
                        },
                        new TreeNode(ServerShellPhrases.MinDataNode)
                        {
                            ImageKey = "server_data.png",
                            SelectedImageKey = "server_data.png",
                            Tag = new TreeNodeTag()
                            {
                                FormType = null,
                                FormArgs = null
                            }
                        },
                        new TreeNode(ServerShellPhrases.HourDataNode)
                        {
                            ImageKey = "server_data.png",
                            SelectedImageKey = "server_data.png",
                            Tag = new TreeNodeTag()
                            {
                                FormType = null,
                                FormArgs = null
                            }
                        },
                        new TreeNode(ServerShellPhrases.EventsNode)
                        {
                            ImageKey = "server_event.png",
                            SelectedImageKey = "server_event.png",
                            Tag = new TreeNodeTag()
                            {
                                FormType = null,
                                FormArgs = null
                            }
                        }
                    })
                {
                    ImageKey = "server_archive.png",
                    SelectedImageKey = "server_archive.png"
                },
                new TreeNode(ServerShellPhrases.ModulesNode)
                {
                    ImageKey = "server_module.png",
                    SelectedImageKey = "server_module.png",
                    Tag = new TreeNodeTag()
                    {
                        FormType = null,
                        FormArgs = new object[] { settings }
                    }
                },
                new TreeNode(ServerShellPhrases.GeneratorNode)
                {
                    ImageKey = "server_generator.png",
                    SelectedImageKey = "server_generator.png",
                    Tag = new TreeNodeTag()
                    {
                        FormType = null,
                        FormArgs = null
                    }
                },
                new TreeNode(ServerShellPhrases.StatsNode)
                {
                    ImageKey = "server_stats.png",
                    SelectedImageKey = "server_stats.png",
                    Tag = new TreeNodeTag()
                    {
                        FormType = null,
                        FormArgs = null
                    }
                },
            };
        }
    }
}