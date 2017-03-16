using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextRemoveElementMessage : NetworkMessage
	{
		public const uint Id = 251;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)251;
			}
		}

		public GameContextRemoveElementMessage()
		{
		}

		public GameContextRemoveElementMessage(double id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
		}
	}
}