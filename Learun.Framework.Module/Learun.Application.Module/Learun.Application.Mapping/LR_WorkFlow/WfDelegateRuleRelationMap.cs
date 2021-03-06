﻿using Learun.Application.WorkFlow;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS-Ultimate V7.0.0 力软敏捷开发框架 
    /// Copyright (c) 2013-2018 上海力软信息技术有限公司 
    /// 创建人：陈彬彬
    /// 日 期：2017.04.17
    /// 描 述：工作流委托规则与工作流模板关联规则
    /// </summary>
    public class WfDelegateRuleRelationMap : EntityTypeConfiguration<WfDelegateRuleRelationEntity>
    {
        public WfDelegateRuleRelationMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_WF_DELEGATERULERELATION");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}