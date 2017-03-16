using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextCreateMessage : NetworkMessage
	{
		public const uint Id = 200;

		public sbyte context;

		public override uint ProtocolId
		{
			get
			{
				return (uint)200;
			}
		}

		public GameContextCreateMessage()
		{
		}

		public GameContextCreateMessage(sbyte context)
		{
			this.context = context;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.context = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.context);
		}
	}
}