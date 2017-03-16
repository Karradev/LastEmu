using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameFightFighterInformations : GameContextActorInformations
	{
		public const short Id = 143;

		public sbyte teamId;

		public sbyte wave;

		public bool alive;

		public GameFightMinimalStats stats;

		public uint[] previousPositions;

		public override short TypeId
		{
			get
			{
				return 143;
			}
		}

		public GameFightFighterInformations()
		{
		}

		public GameFightFighterInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions) : base(contextualId, look, disposition)
		{
			this.teamId = teamId;
			this.wave = wave;
			this.alive = alive;
			this.stats = stats;
			this.previousPositions = previousPositions;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.teamId = reader.ReadSByte();
			this.wave = reader.ReadSByte();
			this.alive = reader.ReadBoolean();
			this.stats = ProtocolTypeManager.GetInstance<GameFightMinimalStats>(reader.ReadUShort());
			this.stats.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.previousPositions = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.previousPositions[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.teamId);
			writer.WriteSByte(this.wave);
			writer.WriteBoolean(this.alive);
			writer.WriteShort(this.stats.TypeId);
			this.stats.Serialize(writer);
			writer.WriteShort((short)((int)this.previousPositions.Length));
			uint[] numArray = this.previousPositions;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}