﻿using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum BankTransactionType
    {
        Unknown = 0,
        [EnumMember(Value = "RECEIVE")]
        Receive = 1,
        [EnumMember(Value = "SPEND")]
        Spend,
        [EnumMember(Value = "RECEIVE-OVERPAYMENT")]
        ReceiveOverpayment,
        [EnumMember(Value = "RECEIVE-PREPAYMENT")]
        ReceivePrepayment,
        [EnumMember(Value = "RECEIVE-TRANSFER")]
        ReceiveTransfer,
        [EnumMember(Value = "SPEND-OVERPAYMENT")]
        SpendOverpayment,
        [EnumMember(Value = "SPEND-PREPAYMENT")]
        SpendPrepayment,
        [EnumMember(Value = "SPEND-TRANSFER")]
        SpendTransfer
    }
}
