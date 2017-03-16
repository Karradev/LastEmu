using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
	{
		public const uint Id = 6188;

		public sbyte magicPoolStatus;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6188;
			}
		}

		public ExchangeCraftResultMagicWithObjectDescMessage()
		{
		}

		public ExchangeCraftResultMagicWithObjectDescMessage(sbyte craftResult, ObjectItemNotInContainer objectInfo, sbyte magicPoolStatus) : base(craftResult, objectInfo)
		{
			this.magicPoolStatus = magicPoolStatus;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.magicPoolStatus = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.magicPoolStatus);
		}
	}
}