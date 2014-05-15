#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;

    public partial class OrderSelectCriteria : EntitySelectCriteria
    {
        public OrderSelectCriteria()
        : base("Order")
        {}
        public OrderSelectCriteria(OrderSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new OrderSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ServerPartitionGUID")]
        public ISearchCondition<ServerEntityKey> ServerPartitionKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServerPartitionKey"))
              {
                 SubCriteria["ServerPartitionKey"] = new SearchCondition<ServerEntityKey>("ServerPartitionKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["ServerPartitionKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="OrderStatusEnum")]
        public ISearchCondition<OrderStatusEnum> OrderStatusEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("OrderStatusEnum"))
              {
                 SubCriteria["OrderStatusEnum"] = new SearchCondition<OrderStatusEnum>("OrderStatusEnum");
              }
              return (ISearchCondition<OrderStatusEnum>)SubCriteria["OrderStatusEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="InsertTime")]
        public ISearchCondition<DateTime> InsertTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("InsertTime"))
              {
                 SubCriteria["InsertTime"] = new SearchCondition<DateTime>("InsertTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["InsertTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="UpdatedTime")]
        public ISearchCondition<DateTime> UpdatedTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("UpdatedTime"))
              {
                 SubCriteria["UpdatedTime"] = new SearchCondition<DateTime>("UpdatedTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["UpdatedTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientGUID")]
        public ISearchCondition<ServerEntityKey> PatientKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("PatientKey"))
              {
                 SubCriteria["PatientKey"] = new SearchCondition<ServerEntityKey>("PatientKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["PatientKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="AccessionNumber")]
        public ISearchCondition<String> AccessionNumber
        {
            get
            {
              if (!SubCriteria.ContainsKey("AccessionNumber"))
              {
                 SubCriteria["AccessionNumber"] = new SearchCondition<String>("AccessionNumber");
              }
              return (ISearchCondition<String>)SubCriteria["AccessionNumber"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ScheduledDateTime")]
        public ISearchCondition<DateTime> ScheduledDateTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("ScheduledDateTime"))
              {
                 SubCriteria["ScheduledDateTime"] = new SearchCondition<DateTime>("ScheduledDateTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["ScheduledDateTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="RequestedProcedureCodeGUID")]
        public ISearchCondition<ServerEntityKey> RequestedProcedureCodeKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("RequestedProcedureCodeKey"))
              {
                 SubCriteria["RequestedProcedureCodeKey"] = new SearchCondition<ServerEntityKey>("RequestedProcedureCodeKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["RequestedProcedureCodeKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Priority")]
        public ISearchCondition<String> Priority
        {
            get
            {
              if (!SubCriteria.ContainsKey("Priority"))
              {
                 SubCriteria["Priority"] = new SearchCondition<String>("Priority");
              }
              return (ISearchCondition<String>)SubCriteria["Priority"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientClass")]
        public ISearchCondition<String> PatientClass
        {
            get
            {
              if (!SubCriteria.ContainsKey("PatientClass"))
              {
                 SubCriteria["PatientClass"] = new SearchCondition<String>("PatientClass");
              }
              return (ISearchCondition<String>)SubCriteria["PatientClass"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ReasonForStudy")]
        public ISearchCondition<String> ReasonForStudy
        {
            get
            {
              if (!SubCriteria.ContainsKey("ReasonForStudy"))
              {
                 SubCriteria["ReasonForStudy"] = new SearchCondition<String>("ReasonForStudy");
              }
              return (ISearchCondition<String>)SubCriteria["ReasonForStudy"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PointOfCare")]
        public ISearchCondition<String> PointOfCare
        {
            get
            {
              if (!SubCriteria.ContainsKey("PointOfCare"))
              {
                 SubCriteria["PointOfCare"] = new SearchCondition<String>("PointOfCare");
              }
              return (ISearchCondition<String>)SubCriteria["PointOfCare"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Room")]
        public ISearchCondition<String> Room
        {
            get
            {
              if (!SubCriteria.ContainsKey("Room"))
              {
                 SubCriteria["Room"] = new SearchCondition<String>("Room");
              }
              return (ISearchCondition<String>)SubCriteria["Room"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Bed")]
        public ISearchCondition<String> Bed
        {
            get
            {
              if (!SubCriteria.ContainsKey("Bed"))
              {
                 SubCriteria["Bed"] = new SearchCondition<String>("Bed");
              }
              return (ISearchCondition<String>)SubCriteria["Bed"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="StudyInstanceUid")]
        public ISearchCondition<String> StudyInstanceUid
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyInstanceUid"))
              {
                 SubCriteria["StudyInstanceUid"] = new SearchCondition<String>("StudyInstanceUid");
              }
              return (ISearchCondition<String>)SubCriteria["StudyInstanceUid"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="EnteredByStaffGUID")]
        public ISearchCondition<ServerEntityKey> EnteredByStaffKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("EnteredByStaffKey"))
              {
                 SubCriteria["EnteredByStaffKey"] = new SearchCondition<ServerEntityKey>("EnteredByStaffKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["EnteredByStaffKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ReferringStaffGUID")]
        public ISearchCondition<ServerEntityKey> ReferringStaffKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("ReferringStaffKey"))
              {
                 SubCriteria["ReferringStaffKey"] = new SearchCondition<ServerEntityKey>("ReferringStaffKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["ReferringStaffKey"];
            } 
        }
    }
}
