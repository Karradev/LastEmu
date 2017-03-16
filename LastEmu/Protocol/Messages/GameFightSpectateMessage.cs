using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightSpectateMessage : NetworkMessage
	{
		public const uint Id = 6069;

		public FightDispellableEffectExtendedInformations[] effects;

		public GameActionMark[] marks;

		public uint gameTurn;

		public int fightStart;

		public Idol[] idols;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6069;
			}
		}

		public GameFightSpectateMessage()
		{
		}

		public GameFightSpectateMessage(FightDispellableEffectExtendedInformations[] effects, GameActionMark[] marks, uint gameTurn, int fightStart, Idol[] idols)
		{
			this.effects = effects;
			this.marks = marks;
			this.gameTurn = gameTurn;
			this.fightStart = fightStart;
			this.idols = idols;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.effects = new FightDispellableEffectExtendedInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.effects[i] = new FightDispellableEffectExtendedInformations();
				this.effects[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.marks = new GameActionMark[num];
			for (int j = 0; j < num; j++)
			{
				this.marks[j] = new GameActionMark();
				this.marks[j].Deserialize(reader);
			}
			this.gameTurn = reader.ReadVarUhShort();
			this.fightStart = reader.ReadInt();
			num = reader.ReadUShort();
			this.idols = new Idol[num];
			for (int k = 0; k < num; k++)
			{
				this.idols[k] = new Idol();
				this.idols[k].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.effects.Length));
			FightDispellableEffectExtendedInformations[] fightDispellableEffectExtendedInformationsArray = this.effects;
			for (int i = 0; i < (int)fightDispellableEffectExtendedInformationsArray.Length; i++)
			{
				fightDispellableEffectExtendedInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.marks.Length));
			GameActionMark[] gameActionMarkArray = this.marks;
			for (int j = 0; j < (int)gameActionMarkArray.Length; j++)
			{
				gameActionMarkArray[j].Serialize(writer);
			}
			writer.WriteVarShort((int)this.gameTurn);
			writer.WriteInt(this.fightStart);
			writer.WriteShort((short)((int)this.idols.Length));
			Idol[] idolArray = this.idols;
			for (int k = 0; k < (int)idolArray.Length; k++)
			{
				idolArray[k].Serialize(writer);
			}
		}
	}
}