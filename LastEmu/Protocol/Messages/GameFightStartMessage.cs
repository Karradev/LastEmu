using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightStartMessage : NetworkMessage
	{
		public const uint Id = 712;

		public Idol[] idols;

		public override uint ProtocolId
		{
			get
			{
				return (uint)712;
			}
		}

		public GameFightStartMessage()
		{
		}

		public GameFightStartMessage(Idol[] idols)
		{
			this.idols = idols;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.idols = new Idol[num];
			for (int i = 0; i < num; i++)
			{
				this.idols[i] = new Idol();
				this.idols[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.idols.Length));
			Idol[] idolArray = this.idols;
			for (int i = 0; i < (int)idolArray.Length; i++)
			{
				idolArray[i].Serialize(writer);
			}
		}
	}
}