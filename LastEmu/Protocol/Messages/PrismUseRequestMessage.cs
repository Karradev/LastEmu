using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismUseRequestMessage : NetworkMessage
	{
		public const uint Id = 6041;

		public sbyte moduleToUse;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6041;
			}
		}

		public PrismUseRequestMessage()
		{
		}

		public PrismUseRequestMessage(sbyte moduleToUse)
		{
			this.moduleToUse = moduleToUse;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.moduleToUse = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.moduleToUse);
		}
	}
}