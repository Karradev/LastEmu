using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
	{
		public const uint Id = 6000;

		public uint objectGenericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6000;
			}
		}

		public ExchangeCraftResultWithObjectIdMessage()
		{
		}

		public ExchangeCraftResultWithObjectIdMessage(sbyte craftResult, uint objectGenericId) : base(craftResult)
		{
			this.objectGenericId = objectGenericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectGenericId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.objectGenericId);
		}
	}
}