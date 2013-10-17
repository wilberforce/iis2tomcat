﻿/*
 *  Copyright (c) 2011 by Bilal Soylu
 *  Bilal Soylu licenses this file to You under the 
 *  Apache License, Version 2.0
 *  (the "License"); you may not use this file except in compliance with
 *  the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*************************************************************************
 * Description: IIS-to-Tomcat connector                                  *
 * Author:      Bilal Soylu <bilal.soylu[at]gmail.com>                   *
 * Version:     1.0                                                      *
 *************************************************************************/

//==============================================================================
// This is a mock class
//==============================================================================
// We will emulate a TCP/IP channel interchange by reading a PCAP file 
// This helps us do unit test and replay request/responses based on actual interchanges
//==============================================================================

using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace BonCodeIIS.Mock
{
    class BonCodeTCPClient:TcpClient
    {
    }
}
