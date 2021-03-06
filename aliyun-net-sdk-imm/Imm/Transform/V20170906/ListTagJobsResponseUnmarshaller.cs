/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListTagJobsResponseUnmarshaller
    {
        public static ListTagJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagJobsResponse listTagJobsResponse = new ListTagJobsResponse();

			listTagJobsResponse.HttpResponse = context.HttpResponse;
			listTagJobsResponse.RequestId = context.StringValue("ListTagJobs.RequestId");
			listTagJobsResponse.NextMarker = context.StringValue("ListTagJobs.NextMarker");

			List<ListTagJobsResponse.ListTagJobs_JobsItem> listTagJobsResponse_jobs = new List<ListTagJobsResponse.ListTagJobs_JobsItem>();
			for (int i = 0; i < context.Length("ListTagJobs.Jobs.Length"); i++) {
				ListTagJobsResponse.ListTagJobs_JobsItem jobsItem = new ListTagJobsResponse.ListTagJobs_JobsItem();
				jobsItem.JobId = context.StringValue("ListTagJobs.Jobs["+ i +"].JobId");
				jobsItem.SetId = context.StringValue("ListTagJobs.Jobs["+ i +"].SetId");
				jobsItem.SrcUri = context.StringValue("ListTagJobs.Jobs["+ i +"].SrcUri");
				jobsItem.Status = context.StringValue("ListTagJobs.Jobs["+ i +"].Status");
				jobsItem.Percent = context.IntegerValue("ListTagJobs.Jobs["+ i +"].Percent");
				jobsItem.CreateTime = context.StringValue("ListTagJobs.Jobs["+ i +"].CreateTime");
				jobsItem.FinishTime = context.StringValue("ListTagJobs.Jobs["+ i +"].FinishTime");

				listTagJobsResponse_jobs.Add(jobsItem);
			}
			listTagJobsResponse.Jobs = listTagJobsResponse_jobs;
        
			return listTagJobsResponse;
        }
    }
}
