using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareErrorMessage : NetworkMessage
	{
		public const uint Id = 6667;

		public sbyte error;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6667;
			}
		}

		public DareErrorMessage()
		{
		}

		public DareErrorMessage(sbyte error)
		{
			this.error = error;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.error = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.error);
		}
	}
}