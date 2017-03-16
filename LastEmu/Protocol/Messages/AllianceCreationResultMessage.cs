using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceCreationResultMessage : NetworkMessage
	{
		public const uint Id = 6391;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6391;
			}
		}

		public AllianceCreationResultMessage()
		{
		}

		public AllianceCreationResultMessage(sbyte result)
		{
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.result);
		}
	}
}