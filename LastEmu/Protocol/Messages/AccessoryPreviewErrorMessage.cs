using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AccessoryPreviewErrorMessage : NetworkMessage
	{
		public const uint Id = 6521;

		public sbyte error;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6521;
			}
		}

		public AccessoryPreviewErrorMessage()
		{
		}

		public AccessoryPreviewErrorMessage(sbyte error)
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