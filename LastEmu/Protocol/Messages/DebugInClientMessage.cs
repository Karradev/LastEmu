using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DebugInClientMessage : NetworkMessage
	{
		public const uint Id = 6028;

		public sbyte level;

		public string message;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6028;
			}
		}

		public DebugInClientMessage()
		{
		}

		public DebugInClientMessage(sbyte level, string message)
		{
			this.level = level;
			this.message = message;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.level = reader.ReadSByte();
			this.message = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.level);
			writer.WriteUTF(this.message);
		}
	}
}