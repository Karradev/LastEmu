using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class KrosmasterInventoryMessage : NetworkMessage
	{
		public const uint Id = 6350;

		public KrosmasterFigure[] figures;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6350;
			}
		}

		public KrosmasterInventoryMessage()
		{
		}

		public KrosmasterInventoryMessage(KrosmasterFigure[] figures)
		{
			this.figures = figures;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.figures = new KrosmasterFigure[num];
			for (int i = 0; i < num; i++)
			{
				this.figures[i] = new KrosmasterFigure();
				this.figures[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.figures.Length));
			KrosmasterFigure[] krosmasterFigureArray = this.figures;
			for (int i = 0; i < (int)krosmasterFigureArray.Length; i++)
			{
				krosmasterFigureArray[i].Serialize(writer);
			}
		}
	}
}