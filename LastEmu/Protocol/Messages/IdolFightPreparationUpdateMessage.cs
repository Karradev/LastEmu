using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IdolFightPreparationUpdateMessage : NetworkMessage
	{
		public const uint Id = 6586;

		public sbyte idolSource;

		public Idol[] idols;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6586;
			}
		}

		public IdolFightPreparationUpdateMessage()
		{
		}

		public IdolFightPreparationUpdateMessage(sbyte idolSource, Idol[] idols)
		{
			this.idolSource = idolSource;
			this.idols = idols;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.idolSource = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.idols = new Idol[num];
			for (int i = 0; i < num; i++)
			{
				this.idols[i] = ProtocolTypeManager.GetInstance<Idol>(reader.ReadUShort());
				this.idols[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.idolSource);
			writer.WriteShort((short)((int)this.idols.Length));
			Idol[] idolArray = this.idols;
			for (int i = 0; i < (int)idolArray.Length; i++)
			{
				Idol idol = idolArray[i];
				writer.WriteShort(idol.TypeId);
				idol.Serialize(writer);
			}
		}
	}
}